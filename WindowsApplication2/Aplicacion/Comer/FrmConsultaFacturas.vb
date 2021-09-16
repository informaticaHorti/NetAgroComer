Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmConsultaFacturas
    Inherits FrConsulta

    Dim Facturas As New E_Facturas(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))


    Dim err As New Errores

    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Clientes.CLI_Codigo, Lb1)
        ParamTx(TxDato2, Clientes.CLI_Codigo, Lb2)
        ParamTx(TxDato3, Facturas.FRA_fecha, Lb3)
        ParamTx(TxDato4, Facturas.FRA_fecha, Lb4)

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

        BtAux.Text = "Contabilizar y Generar FacturaNET"
        BtAux.Width = 200
        'BtAux.Image = 
        BtAux.Visible = True

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
        consulta.SelCampo(Facturas.FRA_idfactura, "IdFactura")
        consulta.SelCampo(Facturas.FRA_serie, "Serie")
        consulta.SelCampo(Facturas.FRA_factura, "Factura")
        consulta.SelCampo(Facturas.FRA_fecha, "Fecha")
        consulta.SelCampo(PuntoVenta.Nombre, "PVenta", Facturas.FRA_idpuntoventa, PuntoVenta.IdPuntoVenta)
        consulta.SelCampo(Facturas.FRA_idcliente, "CodCli")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", Facturas.FRA_idcliente, Clientes.CLI_Codigo)
        consulta.SelCampo(Facturas.FRA_Base1, "Base")
        consulta.SelCampo(Facturas.FRA_Iva1, "Iva")
        consulta.SelCampo(Facturas.FRA_totalfactura, "Total")


        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(Clientes.CLI_Codigo, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(Clientes.CLI_Codigo, "<=", TxDato2.Text)
        If TxDato3.Text.Trim <> "" Then consulta.WheCampo(Facturas.FRA_fecha, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then consulta.WheCampo(Facturas.FRA_fecha, "<=", TxDato4.Text)
        'If RbSI.Checked Then
        '    consulta.WheCampo(Facturas.FRA_idasientoNet, ">", "0")
        'ElseIf RbNO.Checked Then
        '    consulta.WheCampo(Facturas.FRA_idasientoNet, "=", "0")
        'End If

        Dim WHE As String = consulta.Whe
        If RbSI.Checked Then
            If WHE = "" Then
                WHE = " WHERE FRA_IdAsientoNet > 0 AND FRA_IdFacturaNet > 0"
            Else
                WHE = WHE & " AND FRA_IdAsientoNet > 0 AND FRA_IdFacturaNet > 0"
            End If
        ElseIf RbNO.Checked Then
            If WHE = "" Then
                WHE = " WHERE (COALESCE(FRA_IdAsientoNet,0) = 0 OR COALESCE(FRA_IdFacturaNet,0) = 0)"
            Else
                WHE = WHE & " AND (COALESCE(FRA_IdAsientoNet,0) = 0 OR COALESCE(FRA_IdFacturaNet,0) = 0)"
            End If
        End If



        'Punto de venta
        If WHE = "" Then
            WHE = CadenaWhereLista(Facturas.FRA_idpuntoventa, ListadeCombo(cbPuntoVenta), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(Facturas.FRA_idpuntoventa, ListadeCombo(cbPuntoVenta), " AND ")
        End If
        Dim orby As String = " order by Fecha,Factura"
        Dim sel As String = "Select NetAgroComer.dbo.Facturas.FRA_idfactura AS IdFactura, " & vbCrLf
        sel = sel & "FRA_serie AS Serie," & vbCrLf
        sel = sel & "FRA_factura AS Factura, " & vbCrLf
        sel = sel & "FRA_fecha AS Fecha, " & vbCrLf
        sel = sel & "ContabilidadCosta.dbo.PuntoVenta.Nombre AS PVenta, " & vbCrLf
        sel = sel & "FRA_idcliente as CodCli, " & vbCrLf
        sel = sel & "NetAgroComer.dbo.Clientes.CLI_Nombre AS Cliente, " & vbCrLf
        sel = sel & "FRA_base1 + FRA_base2 + FRA_base3 + FRA_base4 AS Base, " & vbCrLf
        sel = sel & "COALESCE(FRA_cuota1,0) + COALESCE(FRA_cuota2,0) + COALESCE(FRA_cuota3,0) + COALESCE(FRA_cuota4,0) + COALESCE(FRA_cuotare1,0) + COALESCE(FRA_cuotare2,0) + COALESCE(FRA_cuotare3,0) + COALESCE(FRA_cuotare4,0)  AS CuotaIva, " & vbCrLf
        sel = sel & "FRA_totalfactura AS Total, " & vbCrLf
        sel = sel & " FRA_IdAsientoNet as IdAsiento," & vbCrLf
        sel = sel & " A.Asiento," & vbCrLf
        sel = sel & " FRA_IdFacturaNet as FacturaNet" & vbCrLf
        sel = sel & " from NetAgroComer.dbo.Facturas " & vbCrLf
        sel = sel & " LEFT OUTER JOIN ContabilidadCosta.dbo.PuntoVenta ON NetAgroComer.dbo.Facturas.FRA_idpuntoventa = ContabilidadCosta.dbo.PuntoVenta.IdPuntoVenta" & vbCrLf
        sel = sel & " LEFT OUTER JOIN NetAgroComer.dbo.Clientes ON NetAgroComer.dbo.Facturas.FRA_idcliente = NetAgroComer.dbo.Clientes.CLI_Idcliente" & vbCrLf
        sel = sel & " LEFT JOIN ContabilidadCosta.dbo.Asientos A ON A.IdAsiento = FRA_IdAsientoNet" & vbCrLf

        Dim sql As String = sel & WHE & orby


        GridView1.Columns.Clear()
        Dim dt As DataTable = Facturas.MiConexion.ConsultaSQL(sql)


        Dim ColSel As New DataColumn("S", GetType(Boolean))
        ColSel.DefaultValue = False
        dt.Columns.Add(ColSel)


        Grid.DataSource = dt

        AñadeResumenCampo("Base", "{0:n2}")
        AñadeResumenCampo("CuotaIva", "{0:n2}")
        AñadeResumenCampo("Total", "{0:n2}")


        AjustaColumnas()

    End Sub


    Private Sub AjustaColumnas()

        Grid.ForceInitialize()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CUOTAIVA", "FECHA", "PVENTA", "SERIE", "FACTURA", "CODCLI", "CLIENTE", "BASE", "TOTAL", "S", "ASIENTO", "FACTURANET"
                    c.Visible = True
                Case Else
                    c.Visible = False


            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "PVENTA"
                    c.MinWidth = 95
                    c.MaxWidth = 95
                Case "FECHA"
                    c.MinWidth = 85
                Case "CODCLI"
                    c.Width = 55
                Case "ASIENTO", "FACTURANET"
                    c.Width = 65

                Case "S"
                    c.MinWidth = 20
                    c.MaxWidth = 20

            End Select
        Next


    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim MostrarContabilizadas As String = ""
                If RbSI.Checked Then
                    MostrarContabilizadas = "S"
                ElseIf RbNO.Checked Then
                    MostrarContabilizadas = "N"
                End If

                Dim lstPuntoVenta As List(Of String) = ListadeCombo(cbPuntoVenta)

                ImprimirInformeConsultaFacturas(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, MostrarContabilizadas, lstPuntoVenta)

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

        Dim PuntoVenta As String = ""


        Dim Contabilizadas As String = ""
        If RbSI.Checked Then
            Contabilizadas = "SI"
        ElseIf RbNO.Checked Then
            Contabilizadas = "NO"
        End If

        Dim lstPuntoVenta As List(Of String) = ListadeCombo(cbPuntoVenta)


        For Each s As String In lstPuntoVenta
            If PuntoVenta.Trim <> "" Then PuntoVenta = PuntoVenta & ","
            PuntoVenta = PuntoVenta & s
        Next


        If TxDato1.Text.Trim <> "" Or TxDato2.Text.Trim <> "" Then LineasDescripcion.Add("Desde cliente " & TxDato1.Text & " hasta cliente " & TxDato2.Text)
        If TxDato3.Text.Trim <> "" Or TxDato4.Text.Trim <> "" Then LineasDescripcion.Add("Desde " & TxDato3.Text & " hasta " & TxDato4.Text)
        If PuntoVenta.Trim <> "" Then LineasDescripcion.Add("Punto de Venta: " & PuntoVenta)
        If Contabilizadas.Trim <> "" Then LineasDescripcion.Add("Contabilizadas: " & Contabilizadas)

        MyBase.Imprimir()
    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)


        If column.FieldName.ToUpper.Trim = "S" Then

            If row("S") = True Then
                row("S") = False
            Else
                Dim IdAsiento As String = row("IdAsiento").ToString & ""
                Dim IdFacturaNet As String = row("FacturaNet").ToString & ""

                If VaInt(IdAsiento) > 0 And VaInt(IdFacturaNet) > 0 Then
                    MsgBox("Factura ya contabilizada")
                Else

                    Dim bGeneraAsiento As Boolean = True
                    Dim Clientes As New E_Clientes(Idusuario, cn)
                    Dim tiposclientes As New E_Tiposclientes(Idusuario, cn)

                    Dim IdCliente As String = (row("CodCli").ToString & "").Trim

                    If Clientes.LeerId(IdCliente) = True Then
                        If tiposclientes.LeerId(Clientes.CLI_IdTipo.Valor) = True Then
                            bGeneraAsiento = ((tiposclientes.TPC_GeneraAsiento.Valor & "").Trim.ToUpper = "S")
                        End If
                    End If

                    If bGeneraAsiento Or VaInt(IdFacturaNet) > 0 Then
                        row("S") = True
                    Else
                        MsgBox("El tipo de cliente no genera asiento. No se contabilizará la factura.")
                    End If

                End If

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

                Dim IdAsiento As String = row("IdAsiento").ToString & ""
                Dim IdFacturaNet As String = row("FacturaNet").ToString & ""

                If VaInt(IdAsiento) = 0 Or VaInt(IdFacturaNet) = 0 Then

                    Dim bGeneraAsiento As Boolean = True
                    Dim Clientes As New E_Clientes(Idusuario, cn)
                    Dim tiposclientes As New E_Tiposclientes(Idusuario, cn)

                    Dim IdCliente As String = (row("CodCli").ToString & "").Trim

                    If Clientes.LeerId(IdCliente) = True Then
                        If tiposclientes.LeerId(Clientes.CLI_IdTipo.Valor) = True Then
                            bGeneraAsiento = ((tiposclientes.TPC_GeneraAsiento.Valor & "").Trim.ToUpper = "S")
                        End If
                    End If


                    If bGeneraAsiento Or VaInt(IdFacturaNet) > 0 Then
                        row("S") = True
                    End If


                End If

            End If

        Next

    End Sub



    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()

        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                bDatos = False
                For Each row As DataRow In dt.Rows
                    If row("S") = True Then bDatos = True
                Next


                If bDatos Then
                    Contabiliza()
                End If


            Else
                bDatos = False
            End If
        Else
            bDatos = False
        End If

        If Not bDatos Then
            MessageBox.Show("No hay facturas seleccionadas para contabilizar")
        End If

    End Sub


    Private Sub Contabiliza()


        If XtraMessageBox.Show("¿Desea contabilizar las facturas marcadas?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim Facturas As New E_Facturas(Idusuario, cn)
            Dim ListaAsientos As New List(Of Integer)

            For indice As Integer = 0 To GridView1.RowCount - 1

                Dim row As DataRow = GridView1.GetDataRow(indice)
                If Not IsNothing(row) Then

                    If row("S") = True Then

                        Dim IdFactura As String = row("IdFactura").ToString & ""

                        If Facturas.LeerId(IdFactura) Then

                            'Si no tiene asiento, contabilizamos
                            'Si no tiene IdFacturaNet, generamos FacturaNet

                            Dim IdAsiento As Integer = VaInt(row("IdAsiento"))
                            Dim IdFacturaNet As Integer = VaInt(row("FacturaNet"))

                            If IdAsiento = 0 Then
                                Dim i As Integer = Facturas.Contabiliza(IdFactura)
                                If i > 0 Then
                                    ListaAsientos.Add(i)
                                End If
                            End If



                        End If

                    End If

                End If

            Next


            If ListaAsientos.Count > 0 Then
                Dim f As New frmVisualizadorAsiento(ListaAsientos, False, "")
                f.ShowDialog()
                MsgBox("Terminado!")
            Else
                MsgBox("no se generaron asientos")
            End If


            Consultar()


        End If


    End Sub



    
End Class