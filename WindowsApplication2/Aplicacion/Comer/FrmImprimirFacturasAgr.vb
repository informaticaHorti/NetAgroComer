
Public Class FrmImprimirFacturasAgr


    Inherits FrConsulta




    Dim Agricultor As New E_Agricultores(Idusuario, cn)
    Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)
    Dim _TipoOperacion As String = ""


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDeFecha, Nothing, LbDFecha, True, Cdatos.TiposCampo.Fecha, True)
        ParamTx(TxaFecha, Nothing, LbAFecha, True, Cdatos.TiposCampo.Fecha, True)
        ParamTx(TxDAgricultor, Nothing, LbdAgricultor, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxAAgricultor, Nothing, LbaAgricultor, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        cbCentro = ComboCentro(cbCentro, MiMaletin.IdCentro)


        AsociarControles(TxDAgricultor, BtBuscaagr1, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbnomAgr1)
        AsociarControles(TxAAgricultor, BtBuscaAgr2, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbNomAgr2)


    End Sub

    Public Sub InitOper(operacion As String)

        Select Case operacion
            Case "IMPRIMIR"
                _TipoOperacion = "I"
                BInforme.Text = "I.Directa"
                LbOperacion.Text = "IMPRIMIR FACTURAS"
                BInforme.Image = My.Resources.Action_file_quick_print_16x16_32
            Case "ANULAR"
                BInforme.Text = "Anular"
                _TipoOperacion = "A"
                LbOperacion.Text = "ANULAR FACTURAS"
                BInforme.Image = My.Resources.Action_cancel_16x16_32
            Case "CONTABILIZAR"
                BInforme.Text = "Contabilizar"
                LbOperacion.Text = "CONTABILIZAR FACTURAS"
                BInforme.Image = My.Resources.App_kservices_16x16_32


                _TipoOperacion = "C"


        End Select

    End Sub

    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


    End Sub





    Private Sub FrmExtractoEnvasesPorMaterial_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        ' BInforme.Visible = False




        '  GridView1.Appearance.GroupRow.Font = nueva_fuente

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub



    Private Sub CargaGrid()

        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(FacturaAgr.FGR_Idfactura, "idfactura")
        Consulta.SelCampo(FacturaAgr.FGR_idempresa, "Emp")
        Consulta.SelCampo(FacturaAgr.FGR_serie, "Serie")
        Consulta.SelCampo(FacturaAgr.FGR_numerofactura, "Numero")
        Consulta.SelCampo(FacturaAgr.FGR_fecha, "Fecha")
        Consulta.SelCampo(Agricultor.AGR_Nombre, "Agricultor", FacturaAgr.FGR_Idagricultor)
        Consulta.SelCampo(FacturaAgr.FGR_TotalFactura, "TotalFactura")

        If TxDAgricultor.Text <> "" Then
            Consulta.WheCampo(FacturaAgr.FGR_Idagricultor, ">=", TxDAgricultor.Text)
        End If
        If TxAAgricultor.Text <> "" Then
            Consulta.WheCampo(FacturaAgr.FGR_Idagricultor, "<=", TxAAgricultor.Text)
        End If
        If TxDeFecha.Text <> "" Then
            Consulta.WheCampo(FacturaAgr.FGR_fecha, ">=", TxDeFecha.Text)
        End If
        If TxaFecha.Text <> "" Then
            Consulta.WheCampo(FacturaAgr.FGR_fecha, "<=", TxaFecha.Text)
        End If

        Select Case _TipoOperacion
            Case "A"
                Consulta.WheCampo(FacturaAgr.FGR_IdLiquidacion, "=", "0")
            Case "C"
                Consulta.WheCampo(FacturaAgr.FGR_IdAsiento, "=", "0")
                Consulta.WheCampo(FacturaAgr.FGR_idempresa, "=", MiMaletin.IdEmpresaCTB.ToString)
        End Select


        Dim sql As String = Consulta.SQL

      
        Dim whe As String = Consulta.Whe
        Dim Prefijo As String = " WHERE "
        If whe <> "" Then
            Prefijo = " AND "
        End If

        sql = sql + CadenaWhereLista(FacturaAgr.FGR_idcentro, ListadeCombo(cbCentro), Prefijo) & vbCrLf
        sql = sql + " order by fgr_FECHA"
        Dim DT As DataTable = FacturaAgr.MiConexion.ConsultaSQL(sql)

        Dim colSel As New DataColumn("S", GetType(Boolean))
        colSel.DefaultValue = False
        DT.Columns.Add(colSel)



        Grid.DataSource = DT
        AjustaColumnas()



    End Sub


    Private Sub AjustaColumnas()


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim
                Case "IDFACTURA"
                    c.Visible = False

                Case "FECHA"
                    c.Width = 200
                Case "SERIE", "FACTURA"
                    c.Width = 150
                Case "AGRICULTOR"
                    c.Width = 400
                Case "IGENERO", "GASTOS", "CANON", "BASEIMP", "CUOTAIVA", "BASERET", "CUOTARET", "CUOTAFONDO", "TOTALFACTURA"
                    c.Width = 200
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n2}"
            End Select

        Next

        AñadeResumenCampo("TotalFactura", "{0:n2}")

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




    Private Sub BInforme_Click(sender As System.Object, e As System.EventArgs) Handles BInforme.Click
        Select Case _TipoOperacion
            Case "I"
                If MsgBox("Desea imprimir las facturas", vbYesNo) = vbYes Then
                    For indice As Integer = 0 To GridView1.RowCount - 1
                        Dim row As DataRow = GridView1.GetDataRow(indice)
                        If Not IsNothing(row) Then
                            If row("S") = True Then
                                Dim IdFactura As String = (row("IdFactura").ToString & "").Trim
                                C1_ImprimirFacturaAgr(Nothing, IdFactura, TipoImpresion.ImpresoraPorDefecto, "")
                            End If
                        End If
                    Next
                End If
            Case "C"
                If MsgBox("Desea contabilizar las facturas", vbYesNo) = vbYes Then
                    Dim ListaAsientos As New List(Of Integer)

                    For indice As Integer = 0 To GridView1.RowCount - 1
                        Dim row As DataRow = GridView1.GetDataRow(indice)
                        If Not IsNothing(row) Then
                            If row("S") = True Then
                                'Dim i As Integer = FacturaAgr.Contabiliza(VaInt(row("idfactura")))
                                'If i > 0 Then
                                '    ListaAsientos.Add(i)
                                'End If
                                Dim lst As List(Of Integer) = FacturaAgr.Contabiliza(VaInt(row("idfactura")))
                                If lst.Count > 0 Then
                                    ListaAsientos.AddRange(lst)
                                End If
                            End If
                        End If
                    Next
                    Dim f As New frmVisualizadorAsiento(ListaAsientos, False, "")
                    f.ShowDialog()
                    Consultar()
                End If
            Case "A"
                If MsgBox("Desea anular las facturas", vbYesNo) = vbYes Then
                    For indice As Integer = 0 To GridView1.RowCount - 1
                        Dim row As DataRow = GridView1.GetDataRow(indice)
                        If Not IsNothing(row) Then
                            If row("S") = True Then
                                Dim i As Integer = VaInt(row("idfactura"))
                                If i > 0 Then
                                    If FacturaAgr.LeerId(i) = True Then

                                        Dim emp As Integer = VaInt(FacturaAgr.FGR_idempresa.Valor)

                                        Dim IdAsiento As Integer = VaInt(FacturaAgr.FGR_IdAsiento.Valor)
                                        Dim IdAsientoREA As Integer = VaInt(FacturaAgr.FGR_IdAsientoREA.Valor)
                                        Dim IdAsientoREA_Ret As Integer = VaInt(FacturaAgr.FGR_IdAsientoREA_Ret.Valor)

                                        Dim Asiento As New E_Asientos(Idusuario, ConexCtb(emp))
                                        Dim AsientoREA As New E_Asientos(Idusuario, ConexCtb(emp))
                                        Dim AsientoREA_Ret As New E_Asientos(Idusuario, ConexCtb(emp))


                                        Dim c As New Contabilizacion.clAsientos
                                        Dim nAsiento As String = ""
                                        Dim nAsientoREA As String = ""
                                        Dim nAsientoREA_Ret As String = ""

                                        'Anula asiento
                                        If IdAsiento > 0 Then
                                            If Asiento.LeerId(IdAsiento) = True Then
                                                nAsiento = Asiento.Asiento.Valor
                                            End If
                                            If nAsiento <> "" Then
                                                c.AnularAsiento(ConexCtb(emp), IdAsiento, nAsiento)
                                            End If
                                        End If

                                        'Anula asiento REA de iva 
                                        If IdAsientoREA > 0 Then
                                            If AsientoREA.LeerId(IdAsientoREA) Then
                                                nAsientoREA = AsientoREA.Asiento.Valor
                                            End If
                                            If nAsientoREA <> "" Then
                                                c.AnularAsiento(ConexCtb(emp), IdAsientoREA, nAsientoREA)
                                            End If
                                        End If

                                        'Anula asiento REA de retenciones
                                        If IdAsientoREA_Ret > 0 Then
                                            If AsientoREA_Ret.LeerId(IdAsientoREA_Ret) Then
                                                nAsientoREA_Ret = AsientoREA_Ret.Asiento.Valor
                                            End If
                                            If nAsientoREA_Ret <> "" Then
                                                c.AnularAsiento(ConexCtb(emp), IdAsientoREA_Ret, nAsientoREA_Ret)
                                            End If
                                        End If

                                        FacturaAgr.Eliminar()

                                    End If
                                End If
                            End If
                        End If
                    Next
                    Consultar()

                End If

        End Select

    End Sub

    Public Overrides Sub GridClik(ByVal row As System.Data.DataRow, ByVal column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        If Not IsNothing(row) Then


            If column.FieldName.ToUpper = "S" Then
                If row("S") = True Then
                    row("S") = False
                Else
                    row("S") = True
                End If


            End If


        End If

    End Sub



  

End Class