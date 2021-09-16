Public Class FrmSelFacCobros


    Dim Facturas As New E_Facturas(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Monedas As New E_Moneda(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Cobroslineas As New E_CobrosLineas(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)



    Private _ListaDePaso As New List(Of String)
    Public ReadOnly Property ListaDePaso As List(Of String)
        Get
            Return _ListaDePaso
        End Get
    End Property



    Public Sub init(ByVal IdCliente As String, ByVal Nombre As String, ByVal DNI As String)

        LbIdCliente.Text = IdCliente
        LbNombre.Text = Nombre
        LbNif.Text = DNI


        CargaGrid()

    End Sub


    Private Sub CargaGrid()

        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(Facturas.FRA_idfactura, "IdFactura")
        Consulta.SelCampo(PuntoVenta.Nombre, "PuntoVenta", Facturas.FRA_idpuntoventa, PuntoVenta.IdPuntoVenta)
        Consulta.SelCampo(Facturas.FRA_fecha, "Fecha")
        Consulta.SelCampo(Facturas.FRA_serie, "Serie")
        Consulta.SelCampo(Facturas.FRA_factura, "Factura")
        Consulta.SelCampo(Facturas.FRA_idcliente, "CodCli")
        Consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", Facturas.FRA_idcliente, Clientes.CLI_Codigo)
        Consulta.SelCampo(Facturas.FRA_totalfactura, "Importe")
        Consulta.SelCampo(Monedas.MON_Nombre, "Moneda", Facturas.FRA_cddivisa, Monedas.MON_IdMoneda)
        Consulta.SelCampo(Facturas.FRA_RefCliente, "Referencia")
        Dim oPendiente As New Cdatos.bdcampo("@COALESCE(FRA_TotalFactura,0) - (SELECT COALESCE(SUM(CBL_importecobradodivisa),0) as Cobrado FROM CobrosLineas WHERE CBL_IdFactura = FRA_IdFactura)", Cdatos.TiposCampo.Importe, 18, 2)
        Consulta.SelCampo(oPendiente, "Pendiente")


        'Consulta.WheCampo(Facturas.FRA_idcliente, "=", LbIdCliente.Text)
        Consulta.WheCampo(Clientes.CLI_Nif, "=", LbNif.Text)
        Consulta.WheCampo(Facturas.FRA_idempresa, "=", MiMaletin.IdEmpresaCTB.ToString)
        'Consulta.WheCampo(Facturas.FRA_campa, "=", LbEjercicio.Text)
        

        Dim sql As String = Consulta.SQL & vbCrLf
        sql = sql & " ORDER BY Fecha, Serie, Factura" & vbCrLf

        Dim dt As DataTable = Facturas.MiConexion.ConsultaSQL(sql)


        'Dim colPte As New DataColumn("Pendiente", GetType(Decimal))
        'dt.Columns.Add(colPte)

        Dim colSel As New DataColumn("S", GetType(System.Boolean))
        colSel.DefaultValue = False
        dt.Columns.Add(colSel)



        'For Each row As DataRow In dt.Rows

        '    Dim IdFactura As String = row("IdFactura").ToString & ""
        '    Dim cobrado As Decimal = Cobroslineas.CobradoFactura(IdFactura)
        '    Dim Pte As Decimal = VaDec(row("Importe")) - cobrado

        '    row("Pendiente") = Pte

        'Next


        Dim dv As New DataView(dt)
        dv.RowFilter = "Pendiente <> 0"
        dt = dv.ToTable


        Grid.DataSource = dt
        AjustaColumnas()


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo(GridView, "Importe", "{0:n2}")
        AñadeResumenCampo(GridView, "Pendiente", "{0:n2}")

        CalculaTotalSeleccionado()

    End Sub


    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView.Columns
            Select Case c.FieldName.Trim.ToUpper

                Case "CODCLI"
                    c.Visible = False

            End Select
        Next


        GridView.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView.Columns
            Select Case c.FieldName.Trim.ToUpper

                Case "CLIENTE"
                    c.Width = 100

            End Select
        Next

    End Sub


    Private Sub FrmSelFacCobros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GridView.OptionsBehavior.Editable = False

    End Sub


    Private Sub btSelTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSelTodos.Click

        For indice As Integer = 0 To GridView.RowCount - 1
            Dim rw As DataRow = GridView.GetDataRow(indice)
            rw("S") = True
        Next

        CalculaTotalSeleccionado()

    End Sub


    Private Sub btSelNinguno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSelNinguno.Click

        For indice As Integer = 0 To GridView.RowCount - 1
            Dim rw As DataRow = GridView.GetDataRow(indice)
            rw("S") = False
        Next

        CalculaTotalSeleccionado()

    End Sub


    Private Sub CalculaTotalSeleccionado()

        Dim total As Decimal = 0

        For indice As Integer = 0 To GridView.RowCount - 1

            Dim row As DataRow = GridView.GetDataRow(indice)
            If Not IsNothing(row) Then

                Dim s As Boolean = False
                Try
                    If row("S") = True Then
                        total = total + row("Pendiente")
                    End If
                Catch ex As Exception

                End Try

            End If

        Next

        LbTotalSeleccionado.Text = total.ToString("#,0.00")

    End Sub


    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.Click

        _ListaDePaso.Clear()
        Me.Close()

    End Sub


    Private Sub btSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSeleccionar.Click

        _ListaDePaso.Clear()

        For indice As Integer = 0 To GridView.RowCount - 1
            Dim rw As DataRow = GridView.GetDataRow(indice)
            If rw("S") = True Then
                _ListaDePaso.Add(rw("IdFactura").ToString & Chr(9) & rw("Pendiente").ToString)
            End If
        Next

        Me.Close()

    End Sub


    Private Sub ChkNif_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargaGrid()
    End Sub


    Private Sub GridView_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick

        Dim column As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        Dim row As DataRow = GridView.GetDataRow(e.RowHandle)

        If column.FieldName = "S" Then

            If row("S") = False Then
                row("S") = True
            Else
                row("S") = False
            End If

            CalculaTotalSeleccionado()

        End If

    End Sub


    Private Sub Grid_Click(sender As System.Object, e As System.EventArgs) Handles Grid.Click

    End Sub
End Class