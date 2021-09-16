Imports DevExpress.XtraEditors.Controls

Public Class FrmEmitirLiquidaciones
    Inherits FrConsulta


    Dim Agricultor As New E_Agricultores(Idusuario, cn)
    Dim Empresas As New E_Empresas(Idusuario, cn)
    Dim Bancos As New E_Bancos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim LiquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)
    Dim CentroR As New E_centrosrecogida(Idusuario, cn)
    Dim DocumentosBancos As New E_DocumentosBancos(Idusuario, cn)
    Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)


    Dim FacturasAgr As New E_FacturaAgr(Idusuario, cn)
    Dim FacturaAgr_Lineas As New E_FacturaAgr_lineas(Idusuario, cn)
    Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)


    Private Class DocumentosEmpresa

        Public IdLiquidacion As Integer

        Public Liquidaciones As List(Of Impreso)
        Public Facturas As List(Of Impreso)


        Public Sub New(IdLiquidacion As Integer)
            Me.IdLiquidacion = IdLiquidacion
        End Sub

        Public Sub AñadeLiquidacion(lst As List(Of Impreso))
            Me.Liquidaciones = lst
        End Sub

        Public Sub AñadeFacturas(lst As List(Of Impreso))
            Me.Facturas = lst
        End Sub

    End Class


    Private Class DocumentosAgricultor

        Public IdLiquidacion As Integer

        Public Liquidaciones As List(Of Impreso)
        Public Facturas As List(Of Impreso)
        Public Clasificaciones As List(Of Listado)


        Public Sub New(IdLiquidacion As Integer)
            Me.IdLiquidacion = IdLiquidacion
        End Sub

        Public Sub AñadeLiquidacion(lst As List(Of Impreso))
            Me.Liquidaciones = lst
        End Sub

        Public Sub AñadeFacturas(lst As List(Of Impreso))
            Me.Facturas = lst
        End Sub

        Public Sub AñadeClasificacion(lst As List(Of Listado))
            Me.Clasificaciones = lst
        End Sub

    End Class


    Private Class Liquidacion

        Public IdLiquidacion As Integer

        Public DocumentosEmpresa As DocumentosEmpresa
        Public DocumentosAgricultor As DocumentosAgricultor


        Public Sub New(IdLiquidacion As Integer)

            Me.IdLiquidacion = IdLiquidacion

            DocumentosEmpresa = New DocumentosEmpresa(IdLiquidacion)
            DocumentosAgricultor = New DocumentosAgricultor(IdLiquidacion)

        End Sub

    End Class


    Private Class LiquidacionesAgricultor

        Public IdAgricultor As Integer

        Public DcLiquidaciones As New Dictionary(Of Integer, Liquidacion)
        Public Liquidaciones As New List(Of Integer)


        Public Sub New(IdAgricultor As Integer)
            Me.IdAgricultor = IdAgricultor
        End Sub


        Public Sub AñadirLiquidacion(Liquidacion As Liquidacion)

            If DcLiquidaciones.ContainsKey(Liquidacion.IdLiquidacion) Then
                DcLiquidaciones(Liquidacion.IdLiquidacion) = Liquidacion
            Else
                DcLiquidaciones(Liquidacion.IdLiquidacion) = Liquidacion
                Liquidaciones.Add(Liquidacion.IdLiquidacion)
            End If

        End Sub


    End Class


    Private Class DocumentosLiquidaciones

        Private DcLiquidacionesAgricultores As New Dictionary(Of Integer, LiquidacionesAgricultor)
        Private LiquidacionesAgricultores As New List(Of Integer)

        Private HojaTransferencia As Impreso = Nothing
        'Private HojaTransferenciaAgr As Impreso = Nothing


        Public Sub AñadirLiquidacionAgricultor(IdAgricultor As Integer, Liquidacion As Liquidacion)

            If DcLiquidacionesAgricultores.ContainsKey(IdAgricultor) Then
                DcLiquidacionesAgricultores(IdAgricultor).AñadirLiquidacion(Liquidacion)
            Else
                Dim LiquidacionesAgricultor As New LiquidacionesAgricultor(IdAgricultor)
                LiquidacionesAgricultor.AñadirLiquidacion(Liquidacion)
                DcLiquidacionesAgricultores(IdAgricultor) = LiquidacionesAgricultor
                LiquidacionesAgricultores.Add(IdAgricultor)
            End If

        End Sub


        Public Sub AñadirHojaTransferencia(Hoja As Impreso)

            Me.HojaTransferencia = Hoja

        End Sub


        'Public Sub AñadirHojaTransferenciaAgricultor(Hoja As Impreso)

        '    Me.HojaTransferenciaAgr = Hoja

        'End Sub


        Public Sub Imprimir(ImpresoraDocumentos As String, bLiquidaciones As Boolean, bFacturas As Boolean, bClasificaciones As Boolean, bHojasTransferencia As Boolean)


            For Each IdAgricultor As Integer In LiquidacionesAgricultores

                If DcLiquidacionesAgricultores.ContainsKey(IdAgricultor) Then

                    Dim LiquidacionesAgricultor As LiquidacionesAgricultor = DcLiquidacionesAgricultores(IdAgricultor)

                    'Sólo se imprimen los documentos de empresa si están marcados las facturas, clasificaciones u hoja resumen
                    If bFacturas Or bLiquidaciones Then
                        ImprimirDocumentosEmpresa(LiquidacionesAgricultor, ImpresoraDocumentos, bLiquidaciones, bFacturas)
                    End If

                    'Sólo se imprimen los documentos de agricultor si están marcados las facturas o la hoja resumen
                    If bFacturas Or bLiquidaciones Or bClasificaciones Then
                        ImprimirDocumentosAgricultor(LiquidacionesAgricultor, ImpresoraDocumentos, bLiquidaciones, bFacturas, bClasificaciones)
                    End If

                End If

            Next


            If bHojasTransferencia Then
                ImprimirHojaTransferencia(ImpresoraDocumentos)
            End If

        End Sub


        Private Sub ImprimirDocumentosEmpresa(LiquidacionesAgricultor As LiquidacionesAgricultor, ImpresoraDocumentos As String, bLiquidaciones As Boolean, bFacturas As Boolean)

            'Fusiona los documentos
            Dim Documentos As New List(Of Object)

            For Each IdLiquidacion As Integer In LiquidacionesAgricultor.Liquidaciones
                If LiquidacionesAgricultor.DcLiquidaciones.ContainsKey(IdLiquidacion) Then

                    Dim Liquidacion As Liquidacion = LiquidacionesAgricultor.DcLiquidaciones(IdLiquidacion)

                    'Liquidaciones
                    If bLiquidaciones Then
                        If Not IsNothing(Liquidacion.DocumentosEmpresa.Liquidaciones) Then Documentos.AddRange(Liquidacion.DocumentosEmpresa.Liquidaciones)
                    End If

                    'Facturas
                    If bFacturas Then
                        If Not IsNothing(Liquidacion.DocumentosEmpresa.Facturas) Then Documentos.AddRange(Liquidacion.DocumentosEmpresa.Facturas)
                    End If

                End If
            Next


            'Impresión
            Dim Impreso As Impreso = Impreso.Merge(Documentos, Drawing.Printing.PaperKind.A4, False, "10mm", "8mm", "10mm")



            If ImpresoraDocumentos.Trim <> "" Then
                Dim ps As New System.Drawing.Printing.PrinterSettings
                ps.PrinterName = ImpresoraDocumentos
                Impreso.f.documento.Print(ps)
            Else
                Impreso.f.documento.Print()
            End If


            Impreso.Dispose()
            Impreso = Nothing

        End Sub


        Private Sub ImprimirDocumentosAgricultor(LiquidacionesAgricultor As LiquidacionesAgricultor, ImpresoraDocumentos As String, bLiquidaciones As Boolean, bFacturas As Boolean, bClasificaciones As Boolean)


            'Fusiona los documentos
            Dim Documentos As New List(Of Object)

            For Each IdLiquidacion As Integer In LiquidacionesAgricultor.Liquidaciones
                If LiquidacionesAgricultor.DcLiquidaciones.ContainsKey(IdLiquidacion) Then

                    Dim Liquidacion As Liquidacion = LiquidacionesAgricultor.DcLiquidaciones(IdLiquidacion)

                    'Liquidaciones
                    If bLiquidaciones Then
                        If Not IsNothing(Liquidacion.DocumentosAgricultor.Liquidaciones) Then Documentos.AddRange(Liquidacion.DocumentosAgricultor.Liquidaciones)
                    End If

                    'Facturas
                    If bFacturas Then
                        If Not IsNothing(Liquidacion.DocumentosAgricultor.Facturas) Then Documentos.AddRange(Liquidacion.DocumentosAgricultor.Facturas)
                    End If

                    'Clasificaciones
                    If bClasificaciones Then
                        If Not IsNothing(Liquidacion.DocumentosAgricultor.Clasificaciones) Then Documentos.AddRange(Liquidacion.DocumentosAgricultor.Clasificaciones)
                    End If

                End If
            Next



            'Impresión
            Dim Impreso As Impreso = Impreso.Merge(Documentos, Drawing.Printing.PaperKind.A4, False, "10mm", "8mm", "10mm")



            If ImpresoraDocumentos.Trim <> "" Then
                Dim ps As New System.Drawing.Printing.PrinterSettings
                ps.PrinterName = ImpresoraDocumentos
                Impreso.f.documento.Print(ps)
            Else
                Impreso.f.documento.Print()
            End If


            Impreso.Dispose()
            Impreso = Nothing

        End Sub



        Private Sub ImprimirHojaTransferencia(ImpresoraDocumentos As String)

            'Fusiona los documentos
            Dim Documentos As New List(Of Object)

            If Not IsNothing(HojaTransferencia) Then Documentos.Add(HojaTransferencia)
            'If Not IsNothing(HojaTransferenciaAgr) Then Documentos.Add(HojaTransferenciaAgr)


            'Impresión
            Dim Impreso As Impreso = Impreso.Merge(Documentos, Drawing.Printing.PaperKind.A4, False, "10mm", "8mm", "10mm")



            If ImpresoraDocumentos.Trim <> "" Then
                Dim ps As New System.Drawing.Printing.PrinterSettings
                ps.PrinterName = ImpresoraDocumentos
                Impreso.f.documento.Print(ps)
            Else
                Impreso.f.documento.Print()
            End If


            Impreso.Dispose()
            Impreso = Nothing

        End Sub


    End Class


    


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
        ParamTx(TxEmpresa, Nothing, Lbempresa, True, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxBanco, Nothing, LbBanco, True, Cdatos.TiposCampo.EnteroPositivo, 0, 3)
        ParamCb_Copia(CbTipoDocPago, Nothing, LbTipoDocumento, Combos.ComboDocumentosCartera)
        ParamTx(TxTalon, Nothing, LbTalon, False, Cdatos.TiposCampo.EnteroPositivo, 0, 10)

        ParamChk(ChFacturas, Nothing, "S", "N")
        ParamChk(ChClasificaciones, Nothing, "S", "N")
        ParamChk(ChResumen, Nothing, "S", "N")
        ParamChk(ChImprimirPagos, Nothing, "S", "N")




        AsociarControles(TxDAgricultor, BtBuscaagr1, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbnomAgr1)
        AsociarControles(TxAAgricultor, BtBuscaAgr2, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbNomAgr2)
        AsociarControles(TxEmpresa, BtEmpresa, Empresas.btBusca, Empresas, Empresas.EMP_Nombre, LbNomEmpresa)
        AsociarControles(TxBanco, BtBanco, Bancos.btBusca, Bancos, Bancos.Nombre, LbNomBanco)



    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


    End Sub





    Private Sub FrmExtractoEnvasesPorMaterial_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load


        BInforme.Text = "I.Directa"
        BInforme.Image = My.Resources.Action_file_quick_print_16x16_32

        BtAux.Visible = True
        BtAux.Text = "Anular"

        CbCentroRecogida = ComboCentrosRecogida(CbCentroRecogida)
        '  GridView1.Appearance.GroupRow.Font = nueva_fuente

        CargaDocumentosPago()



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
        Consulta.SelCampo(LiquidacionAgr.LIQ_ImpFacturas, "Facturas")
        Consulta.SelCampo(LiquidacionAgr.LIQ_ImpAnterior, "Saldo")
        Consulta.SelCampo(LiquidacionAgr.LIQ_DtoAnticipos, "Anticipos")
        Consulta.SelCampo(LiquidacionAgr.LIQ_DtoSumi, "Suministros")
        Consulta.SelCampo(LiquidacionAgr.LIQ_DtoPortes, "Portes")
        Dim Resultado As New Cdatos.bdcampo("@LIQ_impfacturas+liq_ImpAnterior-liq_DTOAnticipos-liq_DTOsumi-liq_DTOportes", Cdatos.TiposCampo.Importe, 15)
        Consulta.SelCampo(Resultado, "Resultado")
        Consulta.SelCampo(LiquidacionAgr.LIQ_Apagar, "Apagar")
        Consulta.SelCampo(Agricultor.AGR_IdFormaPago, "IdFormaPago")
        Consulta.SelCampo(LiquidacionAgr.LIQ_Nutalon, "Talon")


        If ChImprimirPagos.Checked Then

            If VaInt(CbTipoDocPago.SelectedValue) > 0 Then
                Consulta.WheCampo(LiquidacionAgr.LIQ_IdFormaPago, "=", VaInt(CbTipoDocPago.SelectedValue).ToString)
            End If

            Consulta.WheCampo(LiquidacionAgr.LIQ_Nutalon, "=", "0")

        End If


        Consulta.WheCampo(LiquidacionAgr.LIQ_idempresa, "=", TxEmpresa.Text)
        If TxDeFecha.Text <> "" Then
            Consulta.WheCampo(LiquidacionAgr.LIQ_fecha, ">=", TxDeFecha.Text)
        End If
        If TxaFecha.Text <> "" Then
            Consulta.WheCampo(LiquidacionAgr.LIQ_fecha, "<=", TxaFecha.Text)
        End If

        If TxDAgricultor.Text <> "" Then
            Consulta.WheCampo(LiquidacionAgr.LIQ_Idagricultor, ">=", TxDAgricultor.Text)
        End If
        If TxAAgricultor.Text <> "" Then
            Consulta.WheCampo(LiquidacionAgr.LIQ_Idagricultor, "<=", TxAAgricultor.Text)
        End If

        Dim sql As String = Consulta.SQL + CadenaWhereLista(Agricultor.AGR_idcrecogida, ListadeCombo(CbCentroRecogida), " AND ")
        sql = sql & " ORDER BY liq_idagricultor" & vbCrLf

        Dim dt As DataTable = LiquidacionAgr.MiConexion.ConsultaSQL(sql)
        Dim colSel As New DataColumn("S", GetType(System.Boolean))
        colSel.DefaultValue = True
        dt.Columns.Add(colSel)

        Grid.DataSource = dt
        AjustaColumnas()



    End Sub



    Private Sub btSelTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSelTodos.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim rw As DataRow = GridView1.GetDataRow(indice)
            rw("S") = True
        Next

    End Sub


    Private Sub btSelNinguno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSelNinguno.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim rw As DataRow = GridView1.GetDataRow(indice)
            rw("S") = False
        Next

    End Sub


    Private Sub AjustaColumnas()


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDLIQUIDACION", "IDFORMAPAGO"
                    c.Visible = False
                Case "TALON", "SERIE", "NUMERO"

                    c.Width = 100

                Case "FECHA", "CENTROR"
                    c.Width = 150
                Case "FACTURAS", "SALDO", "ANTICIPOS", "SUMINISTROS", "PORTES", "APAGAR", "RESULTADO"
                    c.Width = 200
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n2}"



                Case "CODIGO"
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
        AñadeResumenCampo("Resultado", "{0:n2}")
        AñadeResumenCampo("Apagar", "{0:n2}")

    End Sub


    Private Sub BtAux_Click(sender As System.Object, e As System.EventArgs) Handles BtAux.Click


        'If Mid(TxDato3.Text, 7, 4) <> Mid(TxDato4.Text, 7, 4) Then
        '    MsgBox("Solo se pueden generar semanas dentro del mismo año. Revise las fechas")
        '    Exit Sub
        'End If


        Dim liquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)





        If MsgBox("Desea ANULAR las liquidaciones  ", vbYesNo) = vbNo Then Exit Sub
        Barra.Visible = True
        Dim DT As DataTable = Grid.DataSource
        Barra.Value = DT.Rows.Count

        For Each rw In DT.Rows
            If Barra.Value < Barra.Maximum Then
                Barra.Value = Barra.Value + 1
            End If
            If rw("S") = True Then

                Dim ID As Integer = VaInt(rw("idliquidacion"))
                If liquidacionAgr.LeerId(ID) = True Then
                    Dim idasiento As Integer = VaInt(liquidacionAgr.LIQ_IdAsiento.Valor)
                    Dim emp As Integer = VaInt(liquidacionAgr.LIQ_idempresa.Valor)
                    Dim asiento As New E_Asientos(Idusuario, ConexCtb(emp))
                    Dim c As New Contabilizacion.clAsientos
                    Dim nasiento As String = ""

                    If idasiento > 0 Then
                        If asiento.LeerId(idasiento) = True Then
                            nasiento = asiento.Asiento.Valor
                        End If
                        If nasiento <> "" Then
                            c.AnularAsiento(ConexCtb(emp), idasiento, nasiento)
                        End If
                    End If


                    liquidacionAgr.Eliminar()
                End If
            End If
        Next

        MsgBox("Finalizado")
        Grid.DataSource = Nothing


    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim liquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)

        If MsgBox("Desea imprimir  los documentos  ", vbYesNo) = vbNo Then Exit Sub


        If ChImprimirPagos.Checked Then
            If TxTalon.Text.Trim = "" Then
                MsgBox("Debe introducir un número de documento para el talón/pagaré/transferencia")
                Exit Sub
            End If
        End If



        Dim xml_talon_pagare As String = ""



        If ChImprimirPagos.Checked And VaInt(CbTipoDocPago.SelectedValue) <> E_Agricultores.FormasPago.Transferencia Then

            If CbDocumentoTalon.SelectedIndex < 0 Then
                MsgBox("Debe introducir un documento para el talón/pagaré")
                Exit Sub
            End If

            Dim IdDoc As String = CbDocumentoTalon.SelectedValue & ""
            If VaInt(IdDoc) > 0 Then

                Dim DocumentosBancos As New E_DocumentosBancos(Idusuario, cn)
                If DocumentosBancos.LeerId(IdDoc) Then

                    If VaInt(DocumentosBancos.DDB_IdBanco.Valor) <> VaInt(TxBanco.Text) Then
                        MsgBox("Advertencia, el documento no pertenece al banco introducido")
                    End If

                    xml_talon_pagare = (DocumentosBancos.DDB_Archivo.Valor & "").Trim


                End If

            End If

        End If





        Dim cont As Integer = 0
        Dim bTerminado As Boolean = False

        Barra.Visible = True

        Dim dt As DataTable = Grid.DataSource
        If Not IsNothing(dt) Then

            Barra.Maximum = dt.Rows.Count - 1
            Barra.Value = 0

            Dim NumTalon As Decimal = VaDec(TxTalon.Text)



            Dim ImpresoraDocumentos As String = ""
            Dim ImpresoraTalones As String = ""


            'Por defecto
            If ImpresoraDocumentos.Trim = "" Or ImpresoraTalones.Trim = "" Then
                Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
                If ValoresUsuario.LeerId(Idusuario) Then
                    If ImpresoraDocumentos.Trim = "" Then ImpresoraDocumentos = (ValoresUsuario.VUS_ImpresoraLiquidaciones.Valor & "").Trim
                    If ImpresoraTalones.Trim = "" Then ImpresoraTalones = (ValoresUsuario.VUS_ImpresoraTalones.Valor & "").Trim
                End If
            End If



            'Selecciona impresora para Facturas / Clasificaciones / Hoja resumen
            If ChResumen.Checked Or ChFacturas.Checked Or ChClasificaciones.Checked Or (ChImprimirPagos.Checked And VaInt(CbTipoDocPago.SelectedValue) = E_Agricultores.FormasPago.Transferencia) Then

                Dim frm As New FrmSeleccionImpresora(ImpresoraDocumentos)
                frm.Text = "Seleccionar impresora para Facturas / Clasificaciones / Hoja resumen / Hoja Transferencias"
                frm.ShowDialog()

                If frm.TipoImpresion = TipoImpresion.Cancelar Then
                    Exit Sub
                Else
                    ImpresoraDocumentos = frm.Impresora
                End If

            End If

            'Selecciona impresora para Facturas / Clasificaciones / Hoja resumen
            If ChImprimirPagos.Checked And VaInt(CbTipoDocPago.SelectedValue) <> E_Agricultores.FormasPago.Transferencia Then

                Dim frm As New FrmSeleccionImpresora(ImpresoraTalones)
                frm.Text = "Seleccionar impresora para Talones"
                frm.ShowDialog()

                If frm.TipoImpresion = TipoImpresion.Cancelar Then
                    Exit Sub
                Else
                    ImpresoraTalones = frm.Impresora
                End If

            End If






            Dim Documentos As New DocumentosLiquidaciones
            Dim lstHojasTransferencia As New List(Of String)

            Dim FechaEmision As String = ""
            If dt.Rows.Count > 0 Then
                Dim Fecha As String = (dt.Rows(0)("Fecha").ToString & "").Trim
                If VaDate(Fecha) > VaDate("") Then FechaEmision = Fecha
            End If



            For Each rw In dt.Rows

                If Barra.Value < Barra.Maximum Then
                    Barra.Value = Barra.Value + 1
                End If

                If rw("S") = True Then

                    'Imprimir documentos de la liquidacion
                    Dim IdAgricultor As String = (rw("Codigo").ToString & "").Trim
                    Dim IdLiquidacion As String = (rw("IdLiquidacion").ToString & "").Trim
                    Dim APagar As Decimal = VaDec(rw("Apagar"))
                    Dim IdFormaPagoLiquidacion As Integer = VaInt(rw("IdFormaPago"))
                    bTerminado = ImprimirDocumentos(IdAgricultor, IdLiquidacion, NumTalon, APagar, IdFormaPagoLiquidacion, Documentos, ImpresoraTalones, lstHojasTransferencia, xml_talon_pagare)
                    cont = cont + 1

                End If

            Next


            'En este caso, que es para imprimir los documentos de pago, vemos si EN EL DESPLEGABLE está seleccionada la forma de pago de transferencias. Si es así imprimimos la hoja de transferencias
            Dim bTransferencias As Boolean = (ChImprimirPagos.Checked And VaInt(CbTipoDocPago.SelectedValue) = E_Agricultores.FormasPago.Transferencia)

            If bTransferencias Then
                Dim hoja_transferencia As Impreso = C1_AñadeHojaTransferencia(lstHojasTransferencia, TxBanco.Text, FechaEmision, False, TipoImpresion.ImpresoraPorDefecto)
                Documentos.AñadirHojaTransferencia(hoja_transferencia)

                ''Copia agricultor
                'Dim copia_agricultor As Impreso = C1_AñadeHojaTransferencia(lstHojasTransferencia, TxBanco.Text, FechaEmision, True, TipoImpresion.ImpresoraPorDefecto)
                'Documentos.AñadirHojaTransferenciaAgricultor(copia_agricultor)

            End If

            If ChResumen.Checked Or ChFacturas.Checked Or ChClasificaciones.Checked Or bTransferencias Then
                Documentos.Imprimir(ImpresoraDocumentos, ChResumen.Checked, ChFacturas.Checked, ChClasificaciones.Checked, bTransferencias)
            End If



        Else
            MsgBox("No hay datos que imprimir")
        End If


        If cont > 0 Then
            If bTerminado Then
                MsgBox("Finalizado")
            Else
                MsgBox("Operación cancelada")
            End If
        Else
            MsgBox("No hay datos que imprimir")
        End If


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



    Private Function ImprimirDocumentos(CodAgr As String, IdLiquidacion As String, ByRef NumTalon As Decimal, ByVal APagar As Decimal, ByVal IdFormaPagoLiquidacion As Integer,
                                        ByRef Documentos As DocumentosLiquidaciones,
                                        ByVal ImpresoraTalones As String,
                                        ByRef lstHojasTransferencia As List(Of String),
                                        ByVal xml_talon_pagare As String) As Boolean

        Dim bTerminado As Boolean = True

        Dim TipoImpresion As TipoImpresion = TipoImpresion.ImpresoraSeleccionada





        If VaInt(IdLiquidacion) > 0 Then


            Dim Liquidacion As New Liquidacion(IdLiquidacion)


            Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)


            'Hoja resumen liquidacion
            If ChResumen.Checked Then

                Dim lstDocumentosEmpresa As New List(Of Impreso)
                Dim lstDocumentosAgricultor As New List(Of Impreso)

                Dim impreso_liquidacion1 As Impreso = C1_AñadeLiquidacionAgr(IdLiquidacion, "EJEMPLAR PARA LA EMPRESA", TipoImpresion, "", 0)
                If Not IsNothing(impreso_liquidacion1) Then lstDocumentosEmpresa.Add(impreso_liquidacion1)

                'Sólo se imprime una hoja en caso de liquidación no positiva o la liquidación sea por transferencia. En este caso, la FORMA DE PAGO LA OBTENEMOS DE LA FICHA DEL AGRICULTOR
                'If APagar <= 0 Or (VaInt(CbTipoDocPago.SelectedValue) = E_Agricultores.FormasPago.Transferencia) Then
                If APagar <= 0 Or (IdFormaPagoLiquidacion = E_Agricultores.FormasPago.Transferencia) Then
                    Dim impreso_liquidacion2 As Impreso = C1_AñadeLiquidacionAgr(IdLiquidacion, "EJEMPLAR PARA EL AGRICULTOR", TipoImpresion, "", 0)
                    If Not IsNothing(impreso_liquidacion2) Then lstDocumentosAgricultor.Add(impreso_liquidacion2)
                End If


                If lstDocumentosEmpresa.Count > 0 Then Liquidacion.DocumentosEmpresa.AñadeLiquidacion(lstDocumentosEmpresa)
                If lstDocumentosAgricultor.Count > 0 Then Liquidacion.DocumentosAgricultor.AñadeLiquidacion(lstDocumentosAgricultor)

            End If


            If ChFacturas.Checked Or ChClasificaciones.Checked Or (ChImprimirPagos.Checked And VaInt(CbTipoDocPago.SelectedValue) = E_Agricultores.FormasPago.Transferencia) Then

                Dim sql As String = "SELECT FGR_IdFactura as IdFactura, FGR_IdSemana as IdSemana, FGR_IdAgricultor as IdAgricultor FROM FacturaAgr WHERE FGR_IdLiquidacion = " & IdLiquidacion
                Dim dt As DataTable = LiquidacionAgr.MiConexion.ConsultaSQL(sql)
                If Not IsNothing(dt) Then

                    Dim lstFacturasEmpresa As New List(Of Impreso)
                    Dim lstFacturasAgricultor As New List(Of Impreso)
                    Dim lstClasificacionesAgricultor As New List(Of Listado)


                    For Each row As DataRow In dt.Rows

                        Dim IdFactura As String = (row("IdFactura").ToString & "").Trim
                        Dim IdSemana As String = (row("IdSemana").ToString & "").Trim
                        Dim IdAgricultor As String = (row("IdAgricultor").ToString & "").Trim


                        'Facturas
                        If ChFacturas.Checked Then

                            Dim impreso_factura1 As Impreso = C1_AñadeFacturaAgr(IdFactura, "EJEMPLAR PARA LA EMPRESA", TipoImpresion)
                            Dim impreso_factura2 As Impreso = C1_AñadeFacturaAgr(IdFactura, "EJEMPLAR PARA EL AGRICULTOR", TipoImpresion)

                            If Not IsNothing(impreso_factura1) Then lstFacturasEmpresa.Add(impreso_factura1)
                            If Not IsNothing(impreso_factura2) Then lstFacturasAgricultor.Add(impreso_factura2)

                        End If


                        'Clasificaciones
                        If ChClasificaciones.Checked Then


                            Dim sqlDetalle As String = "SELECT FGR_idagricultor as IdAgricultor, AGR_Nombre as Agricultor, AEN_IdAlbaran as IdAlbaran, AEN_Albaran as Albaran, AEL_Muestreo as Partida, " & vbCrLf
                            sqlDetalle = sqlDetalle & " RIGHT('00' + CAST (AEN_Campa as varchar), 2) + RIGHT('00000' + CAST (AEL_IdCultivo as varchar), 5) as Cultivo, " & vbCrLf
                            sqlDetalle = sqlDetalle & " AEL_ObservacionesProveedor as ObservacionesProveedor, AEN_Fecha as Fecha, FAL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
                            sqlDetalle = sqlDetalle & " FAL_IdCategoria as IdCategoria, CAE_CategoriaCalibre as Categoria, CAE_IdTipoCategoria as IdTipoCategoria, TCA_Nombre as TipoCategoria," & vbCrLf
                            sqlDetalle = sqlDetalle & " (SELECT SUM(FAL_Kilos) FROM FacturaAgr_lineas FAL2 WHERE FAL2.FAL_IdFactura = FAL1.FAL_IdFactura AND FAL2.FAL_IdPartida = FAL1.FAL_IdPartida) as KilosEnt, " & vbCrLf
                            sqlDetalle = sqlDetalle & " FAL_Kilos as Kilos, FAL_Precio as Precio, FAL_Importe as Importe," & vbCrLf
                            sqlDetalle = sqlDetalle & " CASE (SELECT Count(ALC_Id) FROM AlbEntrada_LineasCla WHERE ALC_IdLineaEntrada = AEL_IdLinea) WHEN 0 THEN 'N' ELSE 'S' END AS Clasif" & vbCrLf
                            sqlDetalle = sqlDetalle & " FROM FacturaAgr_Lineas FAL1" & vbCrLf
                            sqlDetalle = sqlDetalle & " LEFT JOIN FacturaAgr ON FGR_IdFactura = FAL_IdFactura" & vbCrLf
                            sqlDetalle = sqlDetalle & " LEFT JOIN Agricultores ON AGR_IdAgricultor = FGR_IdAgricultor" & vbCrLf
                            sqlDetalle = sqlDetalle & " LEFT JOIN AlbEntrada_Lineas ON AEL_IdLinea = FAL_idpartida " & vbCrLf
                            sqlDetalle = sqlDetalle & " LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEL_IdAlbaran" & vbCrLf
                            sqlDetalle = sqlDetalle & " LEFT JOIN Generos ON FAL_IdGenero = GEN_IdGenero" & vbCrLf
                            sqlDetalle = sqlDetalle & " LEFT JOIN CategoriasEntrada ON CAE_id = FAL_IdCategoria" & vbCrLf
                            sqlDetalle = sqlDetalle & " LEFT JOIN TiposDeCategorias ON TCA_Id = CAE_IdTipoCategoria" & vbCrLf
                            sqlDetalle = sqlDetalle & " WHERE FAL_IdFactura = " & IdFactura & vbCrLf


                            Dim campa As Integer = 0
                            Dim año As String = ""
                            Dim Semana As String = ""

                            If SemanasPartes.LeerId(IdSemana) Then
                                campa = VaInt(SemanasPartes.SEV_Ejercicio.Valor).ToString("00")
                                año = (SemanasPartes.SEV_Ano.Valor & "").Trim
                                Semana = (SemanasPartes.SEV_Semana.Valor & "").Trim
                            End If



                            Dim dtDetalle As DataTable = LiquidacionAgr.MiConexion.ConsultaSQL(sqlDetalle)
                            If Not IsNothing(dtDetalle) Then

                                Dim lstEmpresas As New List(Of String)
                                Dim lstRecogida As New List(Of String)

                                Dim FechaDesde As String = ""
                                If VaDate(SemanasPartes.SEV_FechaInicialEntrada.Valor) > VaDate("") Then FechaDesde = VaDate(SemanasPartes.SEV_FechaInicialEntrada.Valor).ToString("dd/MM/yyyy")
                                Dim FechaHasta As String = ""
                                If VaDate(SemanasPartes.SEV_FechaFinalEntrada.Valor) > VaDate("") Then FechaHasta = VaDate(SemanasPartes.SEV_FechaFinalEntrada.Valor).ToString("dd/MM/yyyy")

                                Dim impreso_clasificacion As Listado = C1_AñadeClasificacionAgr(dtDetalle, Semana, campa, año, IdAgricultor, IdAgricultor, FechaDesde, FechaHasta, "", "", lstEmpresas, True, "", "", lstRecogida)
                                If Not IsNothing(impreso_clasificacion) Then
                                    lstClasificacionesAgricultor.Add(impreso_clasificacion)
                                End If


                            End If


                        End If


                        If ChImprimirPagos.Checked And VaInt(CbTipoDocPago.SelectedValue) = E_Agricultores.FormasPago.Transferencia Then
                            If Not lstHojasTransferencia.Contains(VaInt(IdLiquidacion)) Then
                                lstHojasTransferencia.Add(VaInt(IdLiquidacion))
                            End If
                        End If


                    Next

                    If lstFacturasEmpresa.Count > 0 Then Liquidacion.DocumentosEmpresa.AñadeFacturas(lstFacturasEmpresa)
                    If lstFacturasAgricultor.Count > 0 Then Liquidacion.DocumentosAgricultor.AñadeFacturas(lstFacturasAgricultor)
                    If lstClasificacionesAgricultor.Count > 0 Then Liquidacion.DocumentosAgricultor.AñadeClasificacion(lstClasificacionesAgricultor)


                    'If lstHojasTransferencia.Count > 0 Then
                    '    Dim impreso_transferencias As Impreso = C1_AñadeHojaTransferencia(lstHojasTransferencia, TxBanco.Text, TipoImpresion)
                    '    If Not IsNothing(impreso_transferencias) Then Liquidacion.AñadeHojasTransferencia(impreso_transferencias)
                    'End If



                End If

            End If



            'Talones
            If ChImprimirPagos.Checked Then



                Dim IdFormaPago As Integer = VaInt(CbTipoDocPago.SelectedValue)
                Select Case IdFormaPago


                    Case E_Agricultores.FormasPago.Talon, E_Agricultores.FormasPago.Pagare


                        If chkMatricial.Checked Then


                            'Impresión matricial
                            If APagar > 0 Then


                                Dim IdDoc As String = CbDocumentoTalon.SelectedValue & ""


                                Dim DocumentosBancos As New E_DocumentosBancos(Idusuario, cn)
                                If VaInt(IdDoc) > 0 Then
                                    If DocumentosBancos.LeerId(IdDoc) Then

                                        Dim archivo As String = DocumentosBancos.DDB_Archivo.Valor
                                        Dim ruta As String = Application.StartupPath & "\" & ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CARPETA_DOCUMENTOS_BANCARIOS) & "\"

                                        If IO.File.Exists(ruta & archivo) Then

                                            Dim dt As DataTable = ObtenerTablaTalones(IdLiquidacion, NumTalon)
                                            Dim doc As New DocumentoTalonXML(ruta & archivo, dt)


                                            If ImpresoraTalones.Trim <> "" Then
                                                doc.Imprimir(TipoImpresion, ImpresoraTalones)
                                            Else
                                                doc.Imprimir(NetAgro.TipoImpresion.ImpresoraPorDefecto)
                                            End If

                                        Else
                                            MsgBox("No se encuentra la plantilla del talón")
                                        End If

                                    Else
                                        MsgBox("Imposible leer el archivo del documento bancario")
                                    End If

                                End If


                            End If

                        Else

                            'Impresión en A4
                            If APagar > 0 Then


                                Dim IdDoc As String = CbDocumentoTalon.SelectedValue & ""


                                Dim DocumentosBancos As New E_DocumentosBancos(Idusuario, cn)
                                If VaInt(IdDoc) > 0 Then
                                    If DocumentosBancos.LeerId(IdDoc) Then



                                        Dim documento_pago As Impreso = C1_AñadeLiquidacionAgr(IdLiquidacion, "EJEMPLAR PARA EL AGRICULTOR", TipoImpresion, xml_talon_pagare, NumTalon)
                                        If Not IsNothing(documento_pago) Then

                                            If ImpresoraTalones.Trim <> "" Then
                                                documento_pago.Imprimir(TipoImpresion, ImpresoraTalones)
                                            Else
                                                documento_pago.Imprimir(NetAgro.TipoImpresion.ImpresoraPorDefecto)
                                            End If

                                        End If


                                    Else
                                        MsgBox("Imposible leer el archivo del documento bancario")
                                    End If

                                End If


                            End If


                            NumTalon = NumTalon + 1


                        End If



                    Case E_Agricultores.FormasPago.Transferencia

                        If APagar > 0 Then

                            Dim LiquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)
                            If LiquidacionAgr.LeerId(IdLiquidacion) Then
                                LiquidacionAgr.LIQ_Nutalon.Valor = NumTalon.ToString
                                LiquidacionAgr.Actualizar()
                            End If

                            NumTalon = NumTalon + 1

                        End If

                End Select




            End If


            If Not IsNothing(Liquidacion) Then
                Documentos.AñadirLiquidacionAgricultor(VaInt(CodAgr), Liquidacion)
            End If



        End If

        Return bTerminado

    End Function


    Public Function ObtenerTablaTalones(IdLiquidacion As String, ByRef NumTalon As Decimal) As DataTable

        Dim dt As New DataTable


        If VaInt(IdLiquidacion) > 0 Then


            Dim LiquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)
            If LiquidacionAgr.LeerId(IdLiquidacion) Then

                Dim Nombre As String = ""
                Dim Agricultores As New E_Agricultores(Idusuario, cn)
                If Agricultores.LeerId(LiquidacionAgr.LIQ_Idagricultor.Valor) Then
                    Nombre = Agricultores.AGR_Nombre.Valor
                End If


                dt.Columns.Add("IdLiquidacion", GetType(String))
                dt.Columns.Add("Nombre", GetType(String))
                dt.Columns.Add("Importe", GetType(String))
                dt.Columns.Add("NumletA", GetType(String))
                dt.Columns.Add("NumletB", GetType(String))
                dt.Columns.Add("Poblacion", GetType(String))
                dt.Columns.Add("DiaFin", GetType(String))
                dt.Columns.Add("MesFin", GetType(String))
                dt.Columns.Add("AnoFin", GetType(String))
                dt.Columns.Add("NumeroTalon", GetType(String))
                dt.Columns.Add("DiaPag", GetType(String))
                dt.Columns.Add("MesPag", GetType(String))
                dt.Columns.Add("AnoPag", GetType(String))


                Dim row As DataRow = dt.NewRow()
                row("IdLiquidacion") = IdLiquidacion
                row("Nombre") = Nombre
                row("Importe") = "# " & VaDec(LiquidacionAgr.LIQ_Apagar.Valor).ToString("#,##0.00") & " #"

                If VaDate(LiquidacionAgr.LIQ_fecha.Valor) > VaDate("") Then
                    Dim fecha As Date = VaDate(LiquidacionAgr.LIQ_fecha.Valor)
                    row("DiaFin") = NumLetra(fecha.Day, True, True)
                    row("MesFin") = NombreMes(fecha.Month)
                    row("AnoFin") = fecha.ToString("yyyy")
                End If

                If VaDate(LiquidacionAgr.LIQ_FechaVto.Valor) > VaDate("") Then
                    Dim fecha As Date = VaDate(LiquidacionAgr.LIQ_FechaVto.Valor)
                    row("DiaPag") = fecha.Day.ToString
                    row("MesPag") = NombreMes(fecha.Month)
                    row("AnoPag") = fecha.ToString("yyyy")
                End If

                Dim Importe As Decimal = VaDec(LiquidacionAgr.LIQ_Apagar.Valor)
                Dim Numlet As String = NumLetra(Importe, True, False, "Euros", "Céntimos")
                Dim Numlet1 As String = ""
                Dim Numlet2 As String = ""
                parte2Cadena(Numlet, Numlet1, Numlet2, 50)

                row("NumLetA") = Numlet1
                row("NumLetB") = Numlet2

                row("NumeroTalon") = NumTalon.ToString("#")
                NumTalon = NumTalon + 1


                dt.Rows.Add(row)

            Else
                MsgBox("Error al leer la liquidacion con id " & IdLiquidacion)
            End If


        End If


        Return dt

    End Function


    Private Sub CbTipoDocPago_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbTipoDocPago.SelectedIndexChanged

        TxTalon.Text = ""

        CargaDocumentosPago()

    End Sub


    Private Sub CargaDocumentosPago()

        CbDocumentoTalon.DataSource = Nothing

        Dim IdTipoDocumento As String = VaInt(CbTipoDocPago.SelectedValue).ToString

        'Carga documentos
        Dim dt As DataTable = DocumentosBancos.Tabla(IdTipoDocumento)
        CbDocumentoTalon.DataSource = dt
        CbDocumentoTalon.ValueMember = "Id"
        CbDocumentoTalon.DisplayMember = "Nombre"


        CbDocumentoTalon.SelectedIndex = -1

    End Sub

End Class