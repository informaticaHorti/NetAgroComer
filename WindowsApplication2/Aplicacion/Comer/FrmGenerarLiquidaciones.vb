Imports DevExpress.XtraEditors.Controls

Public Class FrmGenerarLiquidaciones


    Inherits FrConsulta





    Dim Agricultor As New E_Agricultores(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)
    Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
    Dim Empresas As New E_Empresas(Idusuario, cn)
    Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)

    Dim DtGrid As New DataTable
    Dim DcFacturas As New Dictionary(Of Integer, Integer)




    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDeFecha, Nothing, LbDFecha, True, Cdatos.TiposCampo.Fecha, 0)
        ParamTx(TxaFecha, Nothing, LbAFecha, True, Cdatos.TiposCampo.Fecha, 0)
        ParamTx(TxEjerfac, Nothing, LbEjerFac, True, Cdatos.TiposCampo.EnteroPositivo, 0, 2)
        ParamTx(TxSemana1, Nothing, LbSemana1, True, Cdatos.TiposCampo.EnteroPositivo, 0, 3)
        ParamTx(TxSemana2, Nothing, LbSemana2, True, Cdatos.TiposCampo.EnteroPositivo, 0, 3)
        ParamTx(TxDAgricultor, Nothing, LbdAgricultor, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxAAgricultor, Nothing, LbaAgricultor, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxEmpresa, Nothing, Lbempresa, True, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxCentro, Nothing, LbCentro, True, Cdatos.TiposCampo.EnteroPositivo, 0, 3)
        ParamTx(TxSerie, Nothing, LbSerie, True, Cdatos.TiposCampo.Cadena, 0, 5)
        ParamTx(TxFechaLiq, Nothing, LbFecha, True, Cdatos.TiposCampo.Fecha, 0, 10)
        ParamTx(TxFechaVtoPagare, Nothing, LbFechaVtoPagare, True, Cdatos.TiposCampo.Fecha, 0, 10)


        AsociarControles(TxDAgricultor, BtBuscaagr1, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbnomAgr1)
        AsociarControles(TxAAgricultor, BtBuscaAgr2, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbNomAgr2)
        AsociarControles(TxEmpresa, BtEmpresa, Empresas.btBusca, Empresas, Empresas.EMP_Nombre, LbNomEmpresa)
        AsociarControles(TxCentro, BtCentro, Centros.btBusca, Centros, Centros.Nombre, LbNomCentro)
        AsociarControles(TxSemana1, BtSemana1, SemanasPartes.btBusca, SemanasPartes)
        AsociarControles(TxSemana2, BtSemana2, SemanasPartes.btBusca, SemanasPartes)

        ' BtSemana1.CL_Filtro = "campa = " + MiMaletin.Ejercicio.ToString
        ' BtSemana2.CL_Filtro = "campa = " + MiMaletin.Ejercicio.ToString


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        TxEjerfac.Text = MiMaletin.Ejercicio.ToString

    End Sub





    Private Sub FrmExtractoEnvasesPorMaterial_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        BInforme.Visible = False
        BtAux.Visible = True
        BtAux.Text = "Generar"

        CbCentroRecogida = ComboCentrosRecogida(CbCentroRecogida)
        CbCentroRecogida.CheckAll()
        '  GridView1.Appearance.GroupRow.Font = nueva_fuente

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub



    Private Sub CargaGrid()


        Dim Generos As New E_Generos(Idusuario, cn)
        Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
        Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim Bancos As New E_Bancos(Idusuario, ConexCtb(VaInt(TxEmpresa.Text)))


        DtGrid = New DataTable
        DtGrid.Columns.Add("Codigo", GetType(System.Int32))
        DtGrid.Columns.Add("Agricultor", GetType(System.String))
        DtGrid.Columns.Add("Facturas", GetType(System.Decimal))
        DtGrid.Columns.Add("Saldo", GetType(System.Decimal))
        DtGrid.Columns.Add("Anticipos", GetType(System.Decimal))
        DtGrid.Columns.Add("Suministros", GetType(System.Decimal))
        DtGrid.Columns.Add("Portes", GetType(System.Decimal))
        DtGrid.Columns.Add("Resultado", GetType(System.Decimal))
        DtGrid.Columns.Add("Apagar", GetType(System.Decimal))
        DtGrid.Columns.Add("Id", GetType(System.Int32))
        DtGrid.Columns.Add("Banco", GetType(System.String))

        Dim Consulta As New Cdatos.E_select

        Consulta.SelCampo(FacturaAgr.FGR_Idfactura, "idfactura")
        Consulta.SelCampo(FacturaAgr.FGR_Idagricultor, "Codigo")
        Consulta.SelCampo(Agricultores.AGR_Nombre, "Agricultor", FacturaAgr.FGR_Idagricultor)
        Consulta.SelCampo(TipoAgricultor.TPA_ctaprov, "CtaProv", Agricultores.AGR_IdTipo)
        Consulta.SelCampo(TipoAgricultor.TPA_ctaanti, "CtaAnt")
        Consulta.SelCampo(TipoAgricultor.TPA_ctasumi, "CtaSum")
        Consulta.SelCampo(TipoAgricultor.TPA_ctaotros, "CtaOtr")
        Consulta.SelCampo(Agricultores.AGR_idBanco, "idbanco")
        Consulta.SelCampo(Bancos.Nombre, "Banco", Agricultores.AGR_idBanco)

        Consulta.SelCampo(FacturaAgr.FGR_TotalFactura, "ImporteFactura")
        Consulta.WheCampo(FacturaAgr.FGR_idempresa, "=", TxEmpresa.Text)
        If TxDeFecha.Text <> "" Then
            Consulta.WheCampo(FacturaAgr.FGR_fecha, ">=", TxDeFecha.Text)
        End If
        If TxaFecha.Text <> "" Then
            Consulta.WheCampo(FacturaAgr.FGR_fecha, "<=", TxaFecha.Text)
        End If

        If TxDAgricultor.Text <> "" Then
            Consulta.WheCampo(FacturaAgr.FGR_Idagricultor, ">=", TxDAgricultor.Text)
        End If
        If TxAAgricultor.Text <> "" Then
            Consulta.WheCampo(FacturaAgr.FGR_Idagricultor, "<=", TxAAgricultor.Text)
        End If

        Consulta.WheCampo(FacturaAgr.FGR_IdLiquidacion, "=", "0")
        Dim sql As String = Consulta.SQL + CadenaWhereLista(Agricultores.AGR_idcrecogida, ListadeCombo(CbCentroRecogida), " AND ")
        sql = sql & " ORDER BY FGR_idagricultor" & vbCrLf


        Dim dt As DataTable = FacturaAgr.MiConexion.ConsultaSQL(sql)

        Dim Nagri As Integer = 0
        Dim TotalFactura As Decimal = 0

        Dim CtaProv As String = ""
        Dim CtaAnt As String = ""
        Dim CtaSum As String = ""
        Dim CtaOtr As String = ""
        Dim IdBanco As Integer = 0
        Dim Banco As String = ""
        Dim Agricultor As String = ""
        DcFacturas.Clear()
        If Not dt Is Nothing Then

            For Each rw In dt.Rows


                Dim idagricultor As Integer = VaInt(rw("Codigo"))
                If idagricultor <> Nagri And Nagri > 0 Then
                    TotalAgricultor(Nagri, Agricultor, IdBanco, Banco, CtaProv, CtaAnt, CtaSum, CtaOtr, TotalFactura)


                    TotalFactura = 0
                End If
                Nagri = idagricultor
                CtaProv = rw("Ctaprov").ToString
                CtaAnt = rw("CtaAnt").ToString
                CtaSum = rw("CtaSum").ToString
                CtaOtr = rw("CtaOtr").ToString
                IdBanco = VaInt(rw("idbanco"))
                Banco = rw("banco").ToString
                Agricultor = rw("Agricultor").ToString


                TotalFactura = TotalFactura + VaDec(rw("importefactura"))
                DcFacturas.Add(VaInt(rw("idfactura")), idagricultor)

            Next
            If Nagri > 0 Then
                TotalAgricultor(Nagri, Agricultor, IdBanco, Banco, CtaProv, CtaAnt, CtaSum, CtaOtr, TotalFactura)
            End If
        End If

        Grid.DataSource = DtGrid
        AjustaColumnas()



    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()
        LineasDescripcion.Add("Empresa: " & TxEmpresa.Text & " " & LbNomEmpresa.Text)
        LineasDescripcion.Add("Semanas: " & TxSemana1.Text & " hasta " & TxSemana2.Text)
        LineasDescripcion.Add("Fecha liquidación: " & TxFechaLiq.Text)

        MyBase.Imprimir()

    End Sub


    Private Sub TotalAgricultor(idagricultor As Integer, Nombre As String, idbanco As Integer, banco As String, CtaProv As String, CtaAnt As String, CtaSum As String, CtaOtr As String, TotalFactura As Decimal)

        CtaProv = Mid(CtaProv + "000000", 1, 6) + Fnc0(idagricultor, 5)
        CtaAnt = Mid(CtaAnt + "000000", 1, 6) + Fnc0(idagricultor, 5)
        CtaSum = Mid(CtaSum + "000000", 1, 6) + Fnc0(idagricultor, 5)
        CtaOtr = Mid(CtaOtr + "000000", 1, 6) + Fnc0(idagricultor, 5)

        Dim SaldoProv As Decimal = 0
        Dim SaldoAnt As Decimal = 0
        Dim SaldoSum As Decimal = 0
        Dim SaldoOtr As Decimal = 0

        Dim lst As New List(Of String)
        lst.Add(CtaProv)
        lst.Add(CtaAnt)
        lst.Add(CtaSum)
        lst.Add(CtaOtr)


        Dim HastaFecha As String = ""
        ' HastaFecha = TxaFecha.Text ' provisional

        Dim dtcuentas As DataTable = SaldoCuentas(lst, VaInt(TxEmpresa.Text), HastaFecha)
        For Each rw In dtcuentas.Rows

            Dim cuenta As String = (rw("NumeroCuenta").ToString & "").Trim

            If cuenta = CtaProv Then
                SaldoProv = -VaDec(rw("saldototal"))
            End If

            If cuenta = CtaAnt Then
                SaldoAnt = VaDec(rw("saldototal"))
            End If

            If cuenta = CtaSum Then
                SaldoSum = VaDec(rw("saldototal"))
            End If

            If cuenta = CtaOtr Then
                SaldoOtr = VaDec(rw("saldototal"))
            End If


        Next

        'SaldoProv = SaldoProv - TotalFactura ' provisional


        Dim Resultado As Decimal = TotalFactura + SaldoProv - SaldoAnt - SaldoSum - SaldoOtr
        Dim Tliquidacion As Decimal = Resultado
        If Tliquidacion < 0 Then
            Tliquidacion = 0
        End If
        '        If Tliquidacion > 0 Then
        DtGrid.Rows.Add(idagricultor, Nombre, TotalFactura, SaldoProv, SaldoAnt, SaldoSum, SaldoOtr, Resultado, Tliquidacion, idbanco, banco)

        '        End If

    End Sub


    Private Sub AjustaColumnas()


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "BANCO"
                    c.Width = 200

                Case "FACTURAS", "ANTICIPOS", "SUMINISTROS", "RESULTADO"
                    c.Width = 200
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n2}"

                Case "SALDO"
                    c.Width = 200
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n2}"
                    c.Caption = "Saldo Anterior"

                Case "PORTES"
                    c.Width = 200
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n2}"
                    c.Caption = "Otros Dtos"

                Case "APAGAR"
                    c.Width = 200
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n2}"
                    c.Caption = "A pagar"


                Case "CODIGO", "ID"
                    c.Width = 100
                Case "AGRICULTOR"
                    c.Width = 400

            End Select

        Next

        AñadeResumenCampo("Facturas", "{0:n2}")
        AñadeResumenCampo("Saldo", "{0:n2}")
        AñadeResumenCampo("Anticipos", "{0:n2}")
        AñadeResumenCampo("Suministros", "{0:n2}")
        AñadeResumenCampo("Portes", "{0:n2}")
        AñadeResumenCampo("Apagar", "{0:n2}")
        AñadeResumenCampo("Resultado", "{0:n2}")

    End Sub


    Private Sub BtAux_Click(sender As System.Object, e As System.EventArgs) Handles BtAux.Click


        'If Mid(TxDato3.Text, 7, 4) <> Mid(TxDato4.Text, 7, 4) Then
        '    MsgBox("Solo se pueden generar semanas dentro del mismo año. Revise las fechas")
        '    Exit Sub
        'End If


        Dim liquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)



        If VaDate(TxFechaLiq.Text) = VaDate("") Then
            MsgBox("Debe introducir un valor en el campo 'Fecha liquidacion'")
            Exit Sub
        End If

        If TxCentro.Text = "" Then
            MsgBox("Debe introducir un centro")
            Exit Sub
        End If

        If TxEmpresa.Text = "" Then
            MsgBox("Debe introducir una empresa")
            Exit Sub
        End If


        If TxSerie.Text = "" Then
            MsgBox("Debe introducir una serie")
            Exit Sub
        End If


        If VaDate(TxFechaVtoPagare.Text) <= VaDate("") Then
            MsgBox("Debe introducir una fecha de vencimiento de los pagarés para los agricultores que usen esta forma de pago")
            Exit Sub
        End If




        If MsgBox("Desea generar las liquidaciones  ", vbYesNo) = vbNo Then Exit Sub
        Barra.Visible = True
        'Barra.Value = DtGrid.Rows.Count


        

        Barra.Value = 0
        If DtGrid.Rows.Count > 0 Then Barra.Maximum = DtGrid.Rows.Count - 1


        For indice As Integer = 0 To DtGrid.Rows.Count - 1

            Dim rw As DataRow = DtGrid.Rows(indice)

            'If Barra.Value < Barra.Maximum Then
            '    Barra.Value = Barra.Value + 1
            'End If
            '            If VaDec(rw("Apagar")) > 0 Then


            Barra.Value = indice


            Dim IdAgricultor As Integer = VaInt(rw("codigo"))

            Dim IdFormaPago As String = ""
            Dim FechaVto As String = ""
            Dim SituacionCartera As String = ""
            Dim TipoDoc As String = ""

            ObtenerDatosCartera(TxFechaLiq.Text, TxFechaVtoPagare.Text, IdAgricultor, IdFormaPago, FechaVto, SituacionCartera, TipoDoc)


            liquidacionAgr.VaciaEntidad()
            Dim id As Integer = liquidacionAgr.MaxId
            Dim numero As Integer = liquidacionAgr.MaxIdCampa(VaInt(TxEmpresa.Text), MiMaletin.Ejercicio, TxSerie.Text)

            liquidacionAgr.LIQ_Idliquidacion.Valor = id.ToString
            liquidacionAgr.LIQ_ejercicio.Valor = MiMaletin.Ejercicio.ToString
            liquidacionAgr.LIQ_idcentro.Valor = TxCentro.Text
            liquidacionAgr.LIQ_idempresa.Valor = TxEmpresa.Text
            liquidacionAgr.LIQ_fecha.Valor = TxFechaLiq.Text
            liquidacionAgr.LIQ_Idagricultor.Valor = IdAgricultor.ToString
            liquidacionAgr.LIQ_numero.Valor = numero
            liquidacionAgr.LIQ_ImpFacturas.Valor = VaDec(rw("Facturas")).ToString
            liquidacionAgr.LIQ_ImpAnterior.Valor = VaDec(rw("Saldo")).ToString
            liquidacionAgr.LIQ_serie.Valor = TxSerie.Text
            liquidacionAgr.LIQ_DtoAnticipos.Valor = VaDec(rw("Anticipos")).ToString
            liquidacionAgr.LIQ_DtoSumi.Valor = VaDec(rw("Suministros")).ToString
            liquidacionAgr.LIQ_DtoPortes.Valor = VaDec(rw("Portes")).ToString
            liquidacionAgr.LIQ_Apagar.Valor = VaDec(rw("Apagar")).ToString
            liquidacionAgr.LIQ_Idbanco.Valor = VaInt(rw("Id")).ToString
            liquidacionAgr.LIQ_DeFecha.Valor = LbFeSemana1.Text
            liquidacionAgr.LIQ_Afecha.Valor = LbFeSemana2.Text

            liquidacionAgr.LIQ_IdFormaPago.Valor = IdFormaPago
            liquidacionAgr.LIQ_FechaVto.Valor = FechaVto
            liquidacionAgr.LIQ_SituacionCartera.Valor = SituacionCartera
            liquidacionAgr.LIQ_TipoDocumento.Valor = TipoDoc

            liquidacionAgr.Insertar()

            For Each idfactura In DcFacturas.Keys
                If DcFacturas(idfactura) = IdAgricultor Then
                    If FacturaAgr.LeerId(idfactura) = True Then
                        FacturaAgr.FGR_IdLiquidacion.Valor = id.ToString
                        FacturaAgr.Actualizar()
                    End If
                End If
            Next
            'End If
        Next

        MsgBox("Finalizado")
        Grid.DataSource = Nothing


    End Sub



    Private Sub ObtenerDatosCartera(ByVal FechaLiquidacion As String, ByVal FechaVtoPagare As String, ByVal IdAgricultor As String, ByRef IdFormaPago As String, ByRef FechaVto As String, ByRef SituacionCartera As String, ByRef TipoDoc As String)

        IdFormaPago = ""
        FechaVto = ""
        SituacionCartera = ""
        TipoDoc = ""




        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        If Agricultores.LeerId(IdAgricultor) Then



            IdFormaPago = (Agricultores.AGR_IdFormaPago.Valor & "").Trim



            'Establecemos la fecha de vencimiento de la liquidación si queremos generar cartera, según el caso
            Select Case VaInt(IdFormaPago)


                Case E_Agricultores.FormasPago.Talon

                    If VaDate(FechaLiquidacion) > VaDate("") Then FechaVto = FechaLiquidacion

                    SituacionCartera = (Agricultores.AGR_SituacionCartera.Valor & "").Trim
                    TipoDoc = (Agricultores.AGR_TipoDocumento.Valor & "").Trim


                Case E_Agricultores.FormasPago.Pagare

                    'If VaDate(FechaLiquidacion) > VaDate("") Then
                    '    Dim DiasVto As Integer = VaInt(Agricultores.AGR_DiasVto.Valor)
                    '    If DiasVto > 0 Then
                    '        FechaVto = DateAdd(DateInterval.Day, DiasVto, VaDate(TxFecha.Text)).ToString("dd/MM/yyyy")
                    '    End If
                    'End If

                    If VaDate(FechaVtoPagare) > VaDate("") Then FechaVto = FechaVtoPagare

                    SituacionCartera = (Agricultores.AGR_SituacionCartera.Valor & "").Trim
                    TipoDoc = (Agricultores.AGR_TipoDocumento.Valor & "").Trim


                Case E_Agricultores.FormasPago.Transferencia

                    'FechaVto = ""
                    If VaDate(FechaLiquidacion) > VaDate("") Then FechaVto = FechaLiquidacion


            End Select



            'If VaInt(IdFormaPago) = E_Agricultores.FormasPago.Pagare Or
            '    VaInt(IdFormaPago) = E_Agricultores.FormasPago.Talon Then

            '    'If VaDate(FechaLiquidacion) > VaDate("") Then
            '    '    Dim DiasVto As Integer = VaInt(Agricultores.AGR_DiasVto.Valor)
            '    '    If DiasVto > 0 Then
            '    '        FechaVto = DateAdd(DateInterval.Day, DiasVto, VaDate(TxFecha.Text)).ToString("dd/MM/yyyy")
            '    '    End If
            '    'End If

            '    SituacionCartera = (Agricultores.AGR_SituacionCartera.Valor & "").Trim
            '    TipoDoc = (Agricultores.AGR_TipoDocumento.Valor & "").Trim

            'End If

        End If

    End Sub


    Protected Overrides Sub RowCellStyle(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn, sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        MyBase.RowCellStyle(row, column, sender, e)


        If Not IsNothing(row) Then

            'Color columna mensajes según haya o no
            If e.Column.FieldName.Trim.ToUpper = "APAGAR" Then
                Select Case VaDec(row("APAGAR"))
                    Case 0
                        e.Appearance.BackColor = Color.Red
                End Select

            End If



        End If


    End Sub



    Private Sub TxaFecha_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxaFecha.TextChanged

    End Sub
    Private Sub LbAFecha_Click(sender As System.Object, e As System.EventArgs) Handles LbAFecha.Click

    End Sub

    Private Sub LbFeSemana1_Click(sender As System.Object, e As System.EventArgs) Handles LbFeSemana1.Click

    End Sub

    Private Sub TxSemana1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxSemana1.TextChanged

    End Sub

    Private Sub TxSemana1_Valida(edicion As Boolean) Handles TxSemana1.Valida
        If edicion = True Then
            If SemanasPartes.LeerSemana(TxEjerfac.Text, TxSemana1.Text) > 0 Then
                LbFeSemana1.Text = SemanasPartes.SEV_FechaInicialEntrada.Valor
            Else
                MsgBox("Semana inexistente")
                TxSemana1.MiError = True
            End If
        End If

    End Sub

    Private Sub TxSemana2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxSemana2.TextChanged

    End Sub

    Private Sub TxSemana2_Valida(edicion As Boolean) Handles TxSemana2.Valida
        If edicion = True Then
            If SemanasPartes.LeerSemana(TxEjerfac.Text, TxSemana2.Text) > 0 Then
                LbFeSemana2.Text = SemanasPartes.SEV_FechaFinalEntrada.Valor
            Else
                MsgBox("Semana inexistente")
                TxSemana2.MiError = True
            End If
        End If

    End Sub

    Private Sub Lb1_Click(sender As System.Object, e As System.EventArgs) Handles LbEjerFac.Click

    End Sub

    Private Sub TxEjerfac_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxEjerfac.TextChanged

    End Sub

    Private Sub TxEjerfac_Valida(edicion As Boolean) Handles TxEjerfac.Valida
        BtSemana1.CL_Filtro = "campa = " + TxEjerfac.Text
        BtSemana2.CL_Filtro = "campa = " + TxEjerfac.Text

    End Sub

End Class