Imports DevExpress.XtraEditors.Controls

Public Class FrmLiquidacionesCTB



    Inherits FrConsulta





    Dim Agricultor As New E_Agricultores(Idusuario, cn)
    Dim Empresas As New E_Empresas(Idusuario, cn)
    Dim Bancos As New E_Bancos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim LiquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)
    Dim CentroR As New E_centrosrecogida(Idusuario, cn)








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







    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


    End Sub





    Private Sub FrmExtractoEnvasesPorMaterial_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False
        BtAux.Visible = True
        BtAux.Text = "Contabilizar"


        '  GridView1.Appearance.GroupRow.Font = nueva_fuente

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub



    Private Sub CargaGrid()



        Dim Consulta As New Cdatos.E_select

        Consulta.SelCampo(LiquidacionAgr.LIQ_Idliquidacion, "idliquidacion")
        Consulta.SelCampo(LiquidacionAgr.LIQ_serie, "Serie")
        Consulta.SelCampo(LiquidacionAgr.LIQ_numero, "Numero")
        Consulta.SelCampo(LiquidacionAgr.LIQ_fecha, "Fecha")
        Consulta.SelCampo(LiquidacionAgr.LIQ_Idagricultor, "codigo")
        Consulta.SelCampo(Agricultor.AGR_Nombre, "Agricultor", LiquidacionAgr.LIQ_Idagricultor)
        Consulta.SelCampo(CentroR.CER_Nombre, "CentroR", Agricultor.AGR_idcrecogida)
        Consulta.SelCampo(LiquidacionAgr.LIQ_Apagar, "Apagar")
        Consulta.SelCampo(LiquidacionAgr.LIQ_Nutalon, "Talon")
        Consulta.SelCampo(Bancos.Nombre, "Banco", LiquidacionAgr.LIQ_Idbanco)


        Consulta.WheCampo(LiquidacionAgr.LIQ_idempresa, "=", MiMaletin.IdEmpresaCTB.ToString)
        Consulta.WheCampo(LiquidacionAgr.LIQ_Apagar, ">", "0")
        Consulta.WheCampo(LiquidacionAgr.LIQ_Nutalon, ">", "0")
        Consulta.WheCampo(LiquidacionAgr.LIQ_IdAsiento, "=", "0")

        If TxDeFecha.Text <> "" Then
            Consulta.WheCampo(LiquidacionAgr.LIQ_fecha, ">=", TxDeFecha.Text)
        End If
        If TxaFecha.Text <> "" Then
            Consulta.WheCampo(LiquidacionAgr.LIQ_fecha, "<=", TxaFecha.Text)
        End If

        Dim sql As String = Consulta.SQL
        sql = sql & " ORDER BY liq_idagricultor" & vbCrLf

        Dim dt As DataTable = LiquidacionAgr.MiConexion.ConsultaSQL(sql)
      
        Grid.DataSource = dt
        AjustaColumnas()



    End Sub
   


    


    Private Sub AjustaColumnas()


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDLIQUIDACION"
                    c.Visible = False
                Case "TALON", "SERIE", "NUMERO"

                    c.Width = 100

                Case "FECHA", "CENTRO", "BANCO"
                    c.Width = 150
                Case "APAGAR"
                    c.Width = 200
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n2}"



                Case "CODIGO"
                    c.Width = 100
                Case "AGRICULTOR"
                    c.Width = 400

            End Select

        Next

        AñadeResumenCampo("Apagar", "{0:n2}")

    End Sub


    Private Sub BtAux_Click(sender As System.Object, e As System.EventArgs) Handles BtAux.Click


        'If Mid(TxDato3.Text, 7, 4) <> Mid(TxDato4.Text, 7, 4) Then
        '    MsgBox("Solo se pueden generar semanas dentro del mismo año. Revise las fechas")
        '    Exit Sub
        'End If


        Dim liquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)





        If MsgBox("Desea CONTABILIZAR las liquidaciones  ", vbYesNo) = vbNo Then Exit Sub
        Barra.Visible = True
        'Dim DT As DataTable = Grid.DataSource
        'Barra.Value = DT.Rows.Count

        Dim ListaAsientos As New List(Of Integer)
        Barra.Value = 0



        If GridView1.RowCount > 0 Then


            Barra.Maximum = GridView1.RowCount - 1


            For indice As Integer = 0 To GridView1.RowCount - 1

                Dim rw As DataRow = GridView1.GetDataRow(indice)
                If Not IsNothing(rw) Then

                    Dim ID As Integer = VaInt(rw("idliquidacion"))
                    Dim I As Integer = liquidacionAgr.Contabiliza(ID)

                    If I > 0 Then
                        ListaAsientos.Add(I)
                    End If

                End If
                

                Barra.Value = indice
                Application.DoEvents()

            Next


        End If


        



        'For Each rw In DT.Rows

        '    If Barra.Value < Barra.Maximum Then
        '        Barra.Value = Barra.Value + 1
        '    End If


        '    Dim ID As Integer = VaInt(rw("idliquidacion"))
        '    'If ChFactura.CheckState = CheckState.Checked Then
        '    '    Dim consulta As New Cdatos.E_select
        '    '    Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)
        '    '    consulta.SelCampo(FacturaAgr.FGR_Idfactura, "idfactura")
        '    '    consulta.WheCampo(FacturaAgr.FGR_IdLiquidacion, "=", ID.ToString)

        '    '    Dim sql As String = consulta.SQL + " order by FGR_fecha"
        '    '    Dim dtf As DataTable = FacturaAgr.MiConexion.ConsultaSQL(sql)
        '    '    If Not dtf Is Nothing Then
        '    '        For Each rwf In dtf.Rows
        '    '            Dim idfactura As Integer = VaInt(rwf("idfactura"))
        '    '            If FacturaAgr.LeerId(idfactura.ToString) = True Then
        '    '                If VaInt(FacturaAgr.FGR_IdAsiento.Valor) = 0 Then
        '    '                    Dim na As Integer = FacturaAgr.Contabiliza(idfactura)
        '    '                    If na > 0 Then
        '    '                        ListaAsientos.Add(na)
        '    '                    End If

        '    '                End If
        '    '            End If
        '    '        Next
        '    '    End If
        '    'End If

        '    Dim I As Integer = liquidacionAgr.Contabiliza(ID)

        '    If I > 0 Then
        '        ListaAsientos.Add(I)
        '    End If

        'Next


        Dim f As New frmVisualizadorAsiento(ListaAsientos, False, "")
        f.ShowDialog()
        Consultar()


     

    End Sub

   



    Private Sub BInforme_Click(sender As System.Object, e As System.EventArgs) Handles BInforme.Click
        'If Mid(TxDato3.Text, 7, 4) <> Mid(TxDato4.Text, 7, 4) Then
        '    MsgBox("Solo se pueden generar semanas dentro del mismo año. Revise las fechas")
        '    Exit Sub
        'End If


        Dim liquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)





        If MsgBox("Desea imprimir  los documentos  ", vbYesNo) = vbNo Then Exit Sub
        Barra.Visible = True
        Dim DT As DataTable = Grid.DataSource
        Barra.Value = DT.Rows.Count

        For Each rw In DT.Rows
            If Barra.Value < Barra.Maximum Then
                Barra.Value = Barra.Value + 1
            End If
            If rw("S").ToString = "S" Then


            End If
        Next

        MsgBox("Finalizado")
        Grid.DataSource = Nothing

    End Sub

    Public Overrides Sub GridClik(ByVal row As System.Data.DataRow, ByVal column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)
        Dim I As Integer = 0

        If column.FieldName.ToUpper = "S" Then
            If row("S") = True Then
                row("S") = False
            Else
                row("S") = True
            End If
        Else
            Dim ID As Integer = VaInt(row("IDLIQUIDACION"))
            Dim FRM As New FrmLiquidacionAgr
            FRM.init(ID.ToString)
            FRM.ShowDialog()


        End If
    End Sub




End Class